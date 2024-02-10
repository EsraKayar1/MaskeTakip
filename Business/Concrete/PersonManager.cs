using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class PersonManager: IApplicantService         //türk uyrukulular
    {
        //Encapsulation
        public void ApplyForMask(Person person) //Fonksiyon-metod-prosedür denir.ApplyForMask->MaskeİçinBaşvur
        {
            
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)  //Bir vatandaş mı, değil mi ona bakıcaz--TC yoksan- yabavcı uyruklu?
        {

            //meernis kpntrolü yapılacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
               
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
          
            
        }
    }
}
