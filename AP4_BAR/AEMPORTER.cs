//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP4_BAR
{
    using System;
    using System.Collections.Generic;
    
    public partial class AEMPORTER
    {
        public int IDCOMMANDE_HER_1 { get; set; }
        public int IDCOMMANDE { get; set; }
        public int ID_USER { get; set; }
        public Nullable<System.DateTime> HEURERETRAIT { get; set; }
        public Nullable<long> CODERETRAIT { get; set; }
    
        public virtual CLIENTS CLIENTS { get; set; }
        public virtual COMMANDE COMMANDE { get; set; }
        public virtual COMMANDE COMMANDE1 { get; set; }
    }
}
