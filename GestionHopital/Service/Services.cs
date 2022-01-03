using GestionHopital.Metier;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GestionHopital.Service
{
    public static class Services
    {
        private const string URL = "http://localhost:";
        public static async Task<string> data(string path)
        {
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.GetAsync(URL + path))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> data(string path,string login,string password)
        {
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.GetAsync(URL + path + login + password))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> data(string path, Patients patients)
        {
            var patientsJson = JsonConvert.SerializeObject(patients);
            var insert = new StringContent(patientsJson, Encoding.UTF8, "application/json");
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.PostAsync(URL + path, insert))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> data(string path, Payements payements)
        {
            var payementsJson = JsonConvert.SerializeObject(payements);
            var insert = new StringContent(payementsJson, Encoding.UTF8, "application/json");
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.PostAsync(URL + path, insert))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> data(string path, Consultations consultations)
        {
            var consultationsJson = JsonConvert.SerializeObject(consultations);
            var insert = new StringContent(consultationsJson, Encoding.UTF8, "application/json");
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.PostAsync(URL + path, insert))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> dataPut(string path, Patients patients)
        {
            var patientsJson = JsonConvert.SerializeObject(patients);
            var insert = new StringContent(patientsJson, Encoding.UTF8, "application/json");
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.PutAsync(URL + path, insert))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> dataPut(string path, Payements payements)
        {
            var payementsJson = JsonConvert.SerializeObject(payements);
            var insert = new StringContent(payementsJson, Encoding.UTF8, "application/json");
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.PutAsync(URL + path, insert))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> dataPut(string path, Consultations consultations)
        {
            var consultationsJson = JsonConvert.SerializeObject(consultations);
            var insert = new StringContent(consultationsJson, Encoding.UTF8, "application/json");
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.PutAsync(URL + path, insert))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

        public static async Task<string> dataDelete(string path)
        {
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resp = await client.DeleteAsync(URL + path))
                {
                    using (HttpContent content = resp.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return data;
        }

    }
}
