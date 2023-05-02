using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
<<<<<<< HEAD
            if (db.SaveChanges() > 0) return obj;
=======
            if (db.SaveChanges() > 0)
                return obj;
>>>>>>> 92f6ecf6d683a4a6094a05d332be4f0162b08275
            return null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Read()
        {
            throw new NotImplementedException();
        }

        public Token Read(string id)
        {
            return db.Tokens.FirstOrDefault(t => t.TKey.Equals(id));
        }

<<<<<<< HEAD
        public Token Update(Token obj)
        {
            var token = Read(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
=======
        public Token Update(Token Obj)
        {
            var token = Read(Obj.TKey);
            db.Entry(token).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0) 
            return Obj;
>>>>>>> 92f6ecf6d683a4a6094a05d332be4f0162b08275
            return null;
        }
    }
}