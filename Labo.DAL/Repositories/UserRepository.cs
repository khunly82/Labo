﻿using Labo.BLL.Interfaces;
using Labo.DAL.Contexts;
using Labo.DL.Entities;
using ToolBox.EF.Repository;

namespace Labo.DAL.Repositories
{
    public class UserRepository(TournamentContext context) : RepositoryBase<User>(context), IUserRepository
    {
        public override User? FindOne(params object[] ids)
        {
            User? u = base.FindOne(ids);
            if(u is null || u.IsDeleted)
            {
                return null;
            }
            return u;
        }
    }
}
