﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mppl.Entitas
{
    public class ModelDokumen
    {
        ojopodoEntities context;
        
        public ModelDokumen()
        {
            context = new ojopodoEntities();
        }

        public void insert(string judul, string pengarang, string alamat_fingerprint, string url_dokumen)
        {
            dokumen dokumenBaru = new dokumen
            {
                judul = judul,
                pengarang = pengarang,
                alamat_fingerprint = alamat_fingerprint,
                url_dokumen = url_dokumen
            };
            context.dokumen.AddObject(dokumenBaru);
            context.SaveChanges();
        }

        public IEnumerable<dokumen> get()
        {
            IEnumerable<dokumen> results = from e in context.dokumen
                                          select e;
            return results;
        }

        public dokumen getById(long id)
        {
            IEnumerable<dokumen> results = from e in context.dokumen
                                          where e.id_dokumen == id
                                          select e;
            return results.First<dokumen>();
        }

        public void update(long id, string judul, string pengarang, string url_dokumen)
        {
            IEnumerable<dokumen> results = from e in context.dokumen
                                          where e.id_dokumen == id
                                          select e;
            foreach (dokumen item in results)
            {
                item.judul = judul;
                item.pengarang = pengarang;
                item.url_dokumen = url_dokumen;
            }
            context.SaveChanges();
        }

        public void delete(long id)
        {
            IEnumerable<dokumen> results = from e in context.dokumen
                                           where e.id_dokumen == id
                                           select e;
            List<dokumen> resultsList = results.ToList<dokumen>();
            foreach (dokumen item in results)
            {
                context.DeleteObject(item);
            }
            context.SaveChanges();
        }
    }
}