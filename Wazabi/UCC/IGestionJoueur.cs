﻿using System.ServiceModel;

namespace Wazabi.UCC
{
    [ServiceContract]
    public interface IGestionJoueur
    {
        [OperationContract]
        void Inscription(JoueurClient joueur);

        [OperationContract]
        JoueurClient Connexion(JoueurClient joueur);
    }
}