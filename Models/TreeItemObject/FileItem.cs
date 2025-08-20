using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab2.Models.TreeItemObject
{
    public class FileItem
    {

        public string Name { get; set; }
        public string FullPath { get; set; }
        public ObservableCollection<FileItem> Children { get; set; } = new ObservableCollection<FileItem>();
        public bool IsDirectory { get; set; }

        public FileItem(string path)
        {
            FullPath = path;
            Name = Path.GetFileName(path);
            IsDirectory = Directory.Exists(path);

            // Load children only for directories
            if (IsDirectory)
            {
                try
                {
                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        Children.Add(new FileItem(dir));
                    }

                    foreach (var file in Directory.GetFiles(path))
                    {
                        if(file.EndsWith(".task"))
                            Children.Add(new FileItem(file));
                    }
                }
                catch { /* Handle access denied or other issues gracefully */ }
            }
        }

        public string teeeeeest()
        {
            return FullPath;
        }

        public override string? ToString()
        {
            return Name;
        }
    }
}
