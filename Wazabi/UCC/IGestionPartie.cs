﻿using System.ServiceModel;
using Wazabi.Client;

namespace Wazabi.UCC
{
    [ServiceContract]
    public interface IGestionPartie
    {
        [OperationContract]
        bool CreerPartie(JoueurClient joueur, string nom);

        [OperationContract]
        bool LancerPartie();

        [OperationContract]
        void Init();

        [OperationContract]
        bool RejoindrePartie(JoueurClient joueur);

        [OperationContract]
        PartieClient PartieCourante();

        [OperationContract]
        void QuitterPartie(JoueurClient joueur);
    }
}