﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNCQ.Domain.Core;

namespace NNCQ.Domain.Files
{
  public  class FileType : IEntity
    {
        [Key]
        public Guid ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(50)]
        public string SortCode { get; set; }

        public FileType() 
        {
            this.ID = Guid.NewGuid();
        }
    }
}
