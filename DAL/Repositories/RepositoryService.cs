using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    internal static class RepositoryService
    {
        private static string _basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content", "Images");
        private static string _placeholder = "PlaceholderBottle.jpg";

        public static void CheckAndSetPlaceholder(this DTO.Models.Item item)
        {
            string imgPath = Path.Combine(_basePath, item.ImgURL);
        
            if (!File.Exists(imgPath))
            {
                item.ImgURL = _placeholder;
            }
        }
        public static void CheckAndSetPlaceholder(this List<DTO.Models.Item> items)

        {
            foreach (var item in items)
            {
                CheckAndSetPlaceholder(item);
            }
        }
    }
}
