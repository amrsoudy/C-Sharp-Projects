﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Verifier(DateTime value, string MachineName, String MachineIP, String UserName, DateTime date);
        void SauvgarderBDD(DateTime value, string MachineName, String MachineIP, String UserName, DateTime date);

        

        // TODO: ajoutez vos opérations de service ici

    

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    // Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "MyWCFService.ContractType".
   
   
    }
}
