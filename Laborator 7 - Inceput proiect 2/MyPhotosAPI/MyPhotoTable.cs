//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotosAPI
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;



    [DataContract(IsReference = true)]
    public partial class MyPhotoTable
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Place { get; set; }
        [DataMember]
        public string Person { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public System.DateTime Create_Date { get; set; }
        [DataMember]
        public string Path { get; set; }
    }
}