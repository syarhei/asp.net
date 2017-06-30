using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;

namespace Video.Models {
    public class Video {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Файл")]
        public string Path { get; private set; }

        [Display(Name = "Название")]
        public string Title { get; private set; }

        public Video() {
            Title = "";
            Path = "";
        }

        public Video(string path, string name) {
            Title = name;
            Path = path;
        }

    }
}