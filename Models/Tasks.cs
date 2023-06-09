﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProjectManagerWebApi.Models
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateDue { get; set; }
        public int ProjectId { get; set; }
        public string AssignedToEmail { get; set; }
        public int Priority { get; set; }
        [JsonIgnore]
        public virtual Projects Project { get; set; }
    }
}