using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using com.jsas.bpd.Models;

namespace com.jsas.bpd.Controllers
{    
    //[Authorize]
    [RoutePrefix("api/TestView")]
    public class TestViewController : BaseController
    {
        public static List<ListOfPersonTest> listOfPersons = new List<ListOfPersonTest>();
        static bool start = true;

        public TestViewController()
        {
            if (start)
            {
                StartListOfPersons();
            }
            start = false;
        }

        public void StartListOfPersons()
        {
            listOfPersons.Clear();
            listOfPersons.Add(new ListOfPersonTest()
            {
                Name = "Name1",
                Adress = "Adress3",
                Age = 23,
                Mail = "mail@m.m",
                Hobby="jgvjgcv"
            });
            listOfPersons.Add(new ListOfPersonTest()
            {
                Name = "Name2",
                Adress = "Adress4",
                Age = 33,
                Mail = "mail333@m.com",
                Hobby="fvhnrupbnrf"
            });
        }

        #region Methods WebAPI
        [Route("")]
        public async Task<HttpResponseMessage> GetNew()
        {
            int t = 0;
            try
            {
                t = await get();

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, t);
        }

        [Route("Get2")]
        public async Task<HttpResponseMessage> Get()
        {
            int t = 0;
            try
            {
                t = await get();

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, t);
        }
        async Task<int> get()
        {
            return await Task.Run(() => { return 1; });
        }       

        [Route("getAllPersons")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAllPersons()
        {
            List<ListOfPersonTest> list = new List<ListOfPersonTest>();
            try
            {
                list = await getAllPersons();

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, new {emptyPerson=new ListOfPersonTest(), items=list});
        }
        async Task<List<ListOfPersonTest>> getAllPersons()
        {
            return await Task.Run(() => {
                return listOfPersons;
            }
            );
        }

        [Route("getPersonsByMail")]
        public async Task<HttpResponseMessage> GetPersonsByMail(string mail)
        {
            ListOfPersonTest list = new ListOfPersonTest();
            try
            {
                list = await getPersonsByMail(mail);

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
        async Task<ListOfPersonTest> getPersonsByMail(string mail)
        {
            return await Task.Run(() => { return listOfPersons.Find(p => p.Mail.Equals(mail.Trim())); });
        }

        [Route("addNewPerson1")]
        //public async Task<HttpResponseMessage> addNewPerson(string name, string adress, string mail, UInt16 age, string hobby)
        public async Task<HttpResponseMessage> addNewPerson(ListOfPersonTest person)
        {
            try
            {
                //ListOfPersonTest person = new ListOfPersonTest();
                //person.Name = name;
                //person.Adress = adress;
                //person.Mail = mail;
                //person.Age = age;
                //person.Hobby = hobby;
                listOfPersons = await addPerson(person);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, listOfPersons);
        }
        async Task<List<ListOfPersonTest>> addPerson(ListOfPersonTest person)
        {
            if(!string.IsNullOrEmpty(person.Name) && !string.IsNullOrEmpty(person.Mail))
                listOfPersons.Add(person);
            return await Task.Run(() => { return listOfPersons; });
        }

        [Route("deletePerson1")]
        [HttpDelete]
        public async Task<HttpResponseMessage> deletePerson(string mail)
        {
            try
            {
                //ListOfPersonTest person = new ListOfPersonTest();
                //person.Name = name;
                //person.Adress = adress;
                //person.Mail = mail;
                //person.Age = age;
                //person.Hobby = hobby;
                listOfPersons = await deletePerson3(mail);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, listOfPersons);
        }
        async Task<List<ListOfPersonTest>> deletePerson3(string mail)
        {
            listOfPersons.Remove(listOfPersons.SingleOrDefault(p => p.Mail.Equals(mail)));
            return await Task.Run(() => { return listOfPersons; });
        }

        [Route("updatePerson1")]
        [HttpPut]
        //public async Task<HttpResponseMessage> addNewPerson(string name, string adress, string mail, UInt16 age, string hobby)
        public async Task<HttpResponseMessage> updatePerson(ListOfPersonTest person)
        {
            try
            {
                //ListOfPersonTest person = new ListOfPersonTest();
                //person.Name = name;
                //person.Adress = adress;
                //person.Mail = mail;
                //person.Age = age;
                //person.Hobby = hobby;
                listOfPersons = await updatePerson4(person);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return Request.CreateResponse(HttpStatusCode.OK, listOfPersons);
        }
        async Task<List<ListOfPersonTest>> updatePerson4(ListOfPersonTest person)
        {
            foreach (ListOfPersonTest person1 in listOfPersons)
            {
                if (person1.Mail.Equals(person.Mail.Trim()))
                {
                    person1.Mail = person.Mail;
                    person1.Name = person.Name;
                    person1.Adress = person.Adress;
                    person1.Age = person.Age;
                    person1.Hobby = person.Hobby;
                }
            }
            return await Task.Run(() => { return listOfPersons; });
        }

        #endregion


    }
}