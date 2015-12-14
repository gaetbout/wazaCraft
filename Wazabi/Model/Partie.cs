//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wazabi.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partie()
        {
            this.Joueurs = new HashSet<JoueurPartie>();
            this.Pioche = new HashSet<Carte>();
        }
    
        public int Id { get; set; }
        public System.DateTime DateHeureCreation { get; set; }
        public bool Sens { get; set; }
        public int Etat { get; set; }
    
        public virtual Joueur Vainqueur { get; set; }
        public virtual Joueur Createur { get; set; }
        public virtual JoueurPartie JoueurCourant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JoueurPartie> Joueurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carte> Pioche { get; set; }
    }
}
