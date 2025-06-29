using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;

namespace AgenciaTurismo.Pages
{
    public class ViewNotesModel : PageModel
    {
        private readonly string _folderPath;
        public List<string> FileNames { get; set; } = new();

        [BindProperty]
        public string FileName { get; set; } = "";

        [BindProperty]
        public string NoteContent { get; set; } = "";

        public string? SelectedContent { get; set; }
        public string? SelectedFile { get; set; }

        public ViewNotesModel(IWebHostEnvironment env)
        {
            _folderPath = Path.Combine(env.WebRootPath, "files");
            Directory.CreateDirectory(_folderPath);
        }

        public void OnGet(string? selected)
        {
            LoadFiles();

            if (!string.IsNullOrEmpty(selected))
            {
                var filePath = Path.Combine(_folderPath, selected);
                if (System.IO.File.Exists(filePath))
                {
                    SelectedFile = selected;
                    SelectedContent = System.IO.File.ReadAllText(filePath);
                }
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(FileName) || string.IsNullOrWhiteSpace(NoteContent))
                return Page();

            var safeFileName = Path.GetFileNameWithoutExtension(FileName);
            var fullPath = Path.Combine(_folderPath, $"{safeFileName}.txt");

            System.IO.File.WriteAllText(fullPath, NoteContent);

            return RedirectToPage("ViewNotes");
        }

        private void LoadFiles()
        {
            var files = Directory.GetFiles(_folderPath, "*.txt");
            FileNames = files
                .Select(Path.GetFileName)
                .Where(f => f != null)
                .Select(f => f!)
                .ToList();
        }
    }
}
