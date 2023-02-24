/***********************************************************************
 * Module:  GuestPatientRepository.cs
 * Purpose: Definition of the Class Repository.SecretaryRepository.GuestPatientRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Repository.SecretaryRepository
{
    public class GuestPatientRepository
    {
        // Zakomentarisao sam ovu radnju.
        /*
       public Model.Secretary.GuestPatient GetGuestPatient(long id)
       {
          // TODO: implement
          return null;
       }
       */

        // Zakomentarisao sam ovu radnju.
        /*
       public void DeleteGuestPatient(long id)
       {
          // TODO: implement
       }
       */

        // Promenio sam ime atributa iz "Path" u "path".
        private String path;

        // Ja sam dodao kod ispod.
        private Dictionary<Guid, Model.Secretary.GuestPatient> repo;

        public GuestPatientRepository()
        {
            this.path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GuestPatientRepository.bin");
            this.repo = new Dictionary<Guid, Model.Secretary.GuestPatient>();

            LoadFile();
        }

        public void AddGuestPatient(Model.Secretary.GuestPatient newGuestPatient)
        {
            if (newGuestPatient.ID == Guid.Empty)
                newGuestPatient.ID = Guid.NewGuid();

            if (repo.ContainsKey(newGuestPatient.ID) == false)
                repo.Add(newGuestPatient.ID, newGuestPatient);

            SaveFile();
        }

        // Dodao sam radnju za promenu postojeceg gostujuceg pacijenta.
        public void ModifyGuestPatient(Model.Secretary.GuestPatient modifiedGuestPatient)
        {
            repo[modifiedGuestPatient.ID].Name = modifiedGuestPatient.Name;
            repo[modifiedGuestPatient.ID].Surname = modifiedGuestPatient.Surname;
            repo[modifiedGuestPatient.ID].BeginTime = modifiedGuestPatient.BeginTime;
            repo[modifiedGuestPatient.ID].EndTime = modifiedGuestPatient.EndTime;
            repo[modifiedGuestPatient.ID].ContactPhone = modifiedGuestPatient.ContactPhone;
            repo[modifiedGuestPatient.ID].DateOfBirth = modifiedGuestPatient.DateOfBirth;

            SaveFile();
        }

        public void DeleteGuestPatient(Model.Secretary.GuestPatient guestPatient)
        {
            repo.Remove(guestPatient.ID);

            SaveFile();
        }

        public Model.Secretary.GuestPatient this[Guid g]
        {
            get
            {
                return repo[g];
            }
            set
            {
                repo[g] = value;
            }
        }

        private void SaveFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(path, FileMode.OpenOrCreate);
                formatter.Serialize(stream, repo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        private void LoadFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(path))
            {
                try
                {
                    stream = File.Open(path, FileMode.Open);
                    repo = (Dictionary<Guid, Model.Secretary.GuestPatient>)formatter.Deserialize(stream);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
            else
            {
                repo = new Dictionary<Guid, Model.Secretary.GuestPatient>();
            }
        }

        public Dictionary<Guid, Model.Secretary.GuestPatient> getAllGuestPatients()
        {
            return repo;
        }
    }
}