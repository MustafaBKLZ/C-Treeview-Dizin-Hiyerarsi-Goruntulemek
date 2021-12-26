using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace C_Treeview_Dizin_Hiyerarsi
{
    public static class TreeViewExtensions
    {
        // TreeView'ı bir dizinden, alt dizinlerinden ve dosyalarından başlatın.
        public static void LoadFromDirectory(this TreeView trv, string directory, int folder_img, int file_img)
        {
            DirectoryInfo dir_info = new DirectoryInfo(directory);
            AddDirectoryNodes(trv, dir_info, null, folder_img, file_img);
        }

        // Bu dizinin düğümünü ve alt düğümlerini ekleyin.
        public static void AddDirectoryNodes(TreeView trv, DirectoryInfo dir_info, TreeNode parent, int folder_img, int file_img)
        {
            // Dizinin düğümünü ekleyin.
            TreeNode dir_node;
            if (parent == null) dir_node = trv.Nodes.Add(dir_info.Name);
            else dir_node = parent.Nodes.Add(dir_info.Name);

            // Klasör görüntüsünü ekleyin.
            if (folder_img >= 0) dir_node.ImageIndex = folder_img;

            // Alt dizinler ekleyin.
            try
            {
                foreach (DirectoryInfo subdir in dir_info.GetDirectories())
                    AddDirectoryNodes(trv, subdir, dir_node, folder_img, file_img);
            }
            catch (System.UnauthorizedAccessException )
            {
                // XX yoluna erişim reddedildi hatalarını görmezden geliyoruz ama bu klasörler ve dosyalar gösterilemez.
            }

            // Dosya düğümleri ekleyin.
            foreach (FileInfo file_info in dir_info.GetFiles())
            {
                TreeNode file_node = dir_node.Nodes.Add(file_info.Name);
                if (file_img >= 0) file_node.ImageIndex = file_img;
            }
        }
    }
}
