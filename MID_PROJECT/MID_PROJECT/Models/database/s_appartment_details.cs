//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MID_PROJECT.Models.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class s_appartment_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public s_appartment_details()
        {
            this.trans_details_sb = new HashSet<trans_details_sb>();
        }
    
        public int id { get; set; }
        public int a_size { get; set; }
        public int s_id { get; set; }
        public string s_name { get; set; }
        public string location { get; set; }
        public int s_nid { get; set; }
        public string s_email { get; set; }
        public string s_num { get; set; }
        public string s_address { get; set; }
        public string h_register_n { get; set; }
        public int price { get; set; }
        public int a_id { get; set; }
        public string img { get; set; }
        public int bed { get; set; }
        public int bath { get; set; }
        public string country { get; set; }
    
        public virtual user_details user_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trans_details_sb> trans_details_sb { get; set; }
    }
}