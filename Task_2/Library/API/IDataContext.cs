﻿namespace Data.API;
public interface IDataContext
{
    public IQueryable<IUsers> Users { get;}
    public IQueryable<ICatalog> Catalogs { get;}
    public IQueryable<IState> States { get;}
    public IQueryable<IReturn> Returns { get;}
    public IQueryable<IRent> Rents { get; }
}