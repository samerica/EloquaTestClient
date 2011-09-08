using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using EloquaTestClient.EloquaServiceNew;

namespace EloquaTestClient
{
    class Program
    {
        public class EloquaInstance
        {


            public EloquaServiceNew.EloquaServiceClient serviceProxy;
            public EloquaProgramService.ExternalActionServiceClient programServiceProxy;
            public DateTime dttLastEloquaAPICall;
            public string strInstanceName;
            public string strUserID;
            public string strUserPassword;


            public EloquaInstance(string InstanceName, string UserID, string UserPassword)
            {

                strInstanceName = InstanceName;
                strUserID = UserID;
                strUserPassword = UserPassword;
                serviceProxy = new EloquaServiceNew.EloquaServiceClient();
                serviceProxy.ClientCredentials.UserName.UserName = strInstanceName + "\\" + strUserID;
                serviceProxy.ClientCredentials.UserName.Password = strUserPassword;
                programServiceProxy = new EloquaProgramService.ExternalActionServiceClient();
                programServiceProxy.ClientCredentials.UserName.UserName = strInstanceName + "\\" + strUserID;
                programServiceProxy.ClientCredentials.UserName.Password = strUserPassword;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                dttLastEloquaAPICall = DateTime.Now.ToUniversalTime().Subtract(TimeSpan.FromMilliseconds(1000));
          }
        }

        static void Main()
        {
            bool success = false;
            int contactId = 0;
            var contactIDs = new int[1];

            try
            {
                #region Setup the Eloqua service

                var service = new EloquaInstance("instance", "userid", "password");

                #endregion


                #region Create a contact using a Dynamic Entity

                // Build a Contact Entity Type object
                EntityType entityType = new EntityType { ID = 0, Name = "Contact", Type = "Base" };


                // Create an Array of Dynamic Entities
                DynamicEntity[] dynamicEntities = new DynamicEntity[1];


                // Create a new Dynamic Entity and add it to the Array of Entities
                dynamicEntities[0] = new DynamicEntity();
                dynamicEntities[0].EntityType = entityType;


                // Create a Dynamic Entity's Field Value Collection
                dynamicEntities[0].FieldValueCollection = new DynamicEntityFields();


                // Add the Contact's Email Address field to the Dynamic Entity’s field collection
                dynamicEntities[0].FieldValueCollection.Add("C_EmailAddress", "cloud_support@eloqua.com");


                // Add the Contact's First Name field to the Dynamic Entity’s field collection
                dynamicEntities[0].FieldValueCollection.Add("C_FirstName", "Cloud");


                // Execute the request
                var result = service.serviceProxy.Create(dynamicEntities);


                // Verify the status of each Contact Create request in the results
                foreach (CreateResult t in result)
                {
                    // Successfull requests return a positive integer value for ID
                    if (t.ID != -1)
                    {
                        contactId = t.ID;
                        success = true;
                    }
                    // Failed requests return a -1 integer value for ID
                    else
                    {
                        // Extract the Error Message and Error Code for each failed Create request
                        foreach (Error createError in t.Errors)
                        {
                            Console.WriteLine(String.Format("Code: {0}", createError.ErrorCode));
                            Console.WriteLine(String.Format("Message: {0}", createError.Message));
                        }
                    }
                }

                #endregion



                #region Retrieve the contact dynamically

                if (success)
                {
                    // Set the ID of the Contact Entity
                    contactIDs[0] = contactId;



                    // Create a new list containing the fields you want populated
                    List<string> fieldList = new List<string>();


                    // Add the Contact’s Email Address to the field list
                    fieldList.Add("C_EmailAddress");


                    // Add the Contact’s First Name to the field list
                    fieldList.Add("C_FirstName");


                    // Build a Dynamic Entity array to store the results
                    DynamicEntity[] retrievedEntities;


                    // If the field list is empty - the request will return all Entity Fields
                    // Otherwise, only fields defined in the field list are returned
                    if (fieldList.Count == 0)
                    {
                        // Execute the request and return all of the Entity's fields
                        retrievedEntities = service.serviceProxy.Retrieve(entityType, contactIDs, null);
                    }
                    else
                    {
                        // Execute the request and return only the selected Entity fields
                        retrievedEntities = service.serviceProxy.Retrieve(entityType, contactIDs, fieldList.ToArray());
                    }

                    // If a result was found, extract the field values for each Dynamic Entity
                    if (retrievedEntities.Length > 0)
                    {
                        foreach (DynamicEntity dynamicEntity in retrievedEntities)
                        {
                            // Extract the Field Name and Value for each element in the collection
                            foreach (KeyValuePair<string, string> keyValPair in dynamicEntity.FieldValueCollection)
                            {

                                Console.WriteLine("New Contact Created Successfully!");
                                Console.WriteLine(String.Format("Field Name: {0}", keyValPair.Key));
                                Console.WriteLine(String.Format("Field Value: {0}", keyValPair.Value));
                            }
                        }
                    }
                }
                #endregion


                // Customize your own error handling
            }
            catch (System.ServiceModel.FaultException ex)
            {
                // Catch Service Model Fault Exceptions
                Console.WriteLine(String.Format("Reson: {0}", ex.Reason.ToString()));
                Console.WriteLine(String.Format("Fault Type: {0}", ex.GetType().ToString()));
                Console.WriteLine(String.Format("Fault Code: {0}", ex.Code.Name.ToString()));
            }
            catch (Exception ex)
            {
                // Catch System Exceptions
                Console.WriteLine(String.Format("Exception Message: {0}", ex.Message.ToString()));
            }

            // Wait for user input before stepping out.
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}
