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
    
    public partial class CATEGORISER
    {
        public int IDALLERGENE { get; set; }
        public int ID_PRODUIT { get; set; }
        public int ID_ALLERGENE { get; set; }
    
        public virtual ALLERGENE ALLERGENE { get; set; }
        public virtual PRODUIT PRODUIT { get; set; }
    }
}