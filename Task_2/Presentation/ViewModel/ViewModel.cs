using Service.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Presentation.Model;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Presentation;

public class ViewModel 
{
    private IModel model;
    public ViewModel(IModel model)
    {
        
        //TO DO:
        /*
        this.model = model;
        addBookCommand = new(this);
        updateBookCommand = new(this);
        deleteBookCommand = new(this);
        addStateCommand = new(this);
        updateStateCommand = new(this);
        deleteStateCommand = new(this);
        addUserCommand = new(this);
        updateUserCommand = new(this);
        deleteUserCommand = new(this);
        addEventCommand = new(this);
        updateEventCommand = new(this);
        deleteEventCommand = new(this);
        Task.Run(() => RefreshBooks());
        Thread.Sleep(100);
        Task.Run(() => RefreshStates());
        Thread.Sleep(100);
        Task.Run(() => RefreshUsers());
        Thread.Sleep(100);
        Task.Run(() => RefreshEvents());
        */
    }

    //Catalog / INFO BOOK

    private IEnumerable<ICatalogModel> catalogModel;
    public IEnumerable<ICatalogModel> CatalogModel
    {
        get
        {
            return catalogModel;
        }
        set
        {
            catalogModel = value;
        }
    }
    private ICatalogModel selectedInfo;

    public ICatalogModel SelectedInfo
    {
        get { return selectedInfo; }
        set { 
            selectedInfo = value;
            OnPropertyChanged("SelectedInfo");
        }
    }
    //TO IMPLEMENT SERVICE??
    private async Task RefreshBooks()
    {
        CatalogModel = await Task.Run(() => model.Service.GetBooks());
    }

    public async Task TAddCatalog()
    {
        try
        {
            await Task.Run(() => model.Service.TAddCatalog(SelectedInfo.InfoId, SelectedInfo.Title, SelectedInfo.Author));
            await Task.Run(() => RefreshBooks()); // idk co to robi
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Błędzik tu");
        }
    }
    public async Task TUpdateCatalog()
    {
        try
        {
            await Task.Run(() => model.Service.TUpdateCatalog(SelectedInfo.InfoId, SelectedInfo.Title, SelectedInfo.Author));
            await Task.Run(() => RefreshBooks()); // co to??
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Błędzik tu");
        }
    }
    public async Task TDeleteCatalog()
    {
        try
        {
            await Task.Run(() => model.Service.TDeleteCatalog(SelectedInfo.InfoId, SelectedInfo.Title, SelectedInfo.Author));
            await Task.Run(() => RefreshBooks()); //idk co tu
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Błędzik tu");
        }
    }
    //States / Physical books in library
    private IEnumerable<IStateModel> stateModel;

    public IEnumerable<IStateModel> StateModel
    {
        get
        {
            return stateModel;
        }
        set
        {
            stateModel = value;
        }
    }

    private IStateModel selectedBook;

    public IStateModel SelectedBook
    {
        get
        {
            return selectedBook;
        }
        set
        {
            selectedBook = value;
            OnPropertyChanged("SelectedBook");
        }
    }
    // nwm co to robi
    private async Task RefreshStates()
    {
        ModelStates = await Task.Run(() => model.Service.GetStates());
    }
    
    public async Task TAddState()
    {
        try
        {
            await Task.Run(() => model.Service.TAddState(SelectedBook.BookId, SelectedBook.InfoId));
            await Task.Run(() => RefreshStates()); //idk co to
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
    public async Task TUpdateState()
    {
        try
        {
            await Task.Run(() => model.Service.TUpdateState(SelectedBook.BookId, SelectedBook.InfoId));
            await Task.Run(() => RefreshStates());
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
    public async Task TDeleteState()
    {
        try
        {
            await Task.Run(() => model.Service.TDeleteState(SelectedBook.BookId, SelectedBook.InfoId));
            await Task.Run(() => RefreshStates());
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }

    //Users
    private IEnumerable<IUsersModel> usersModel;
    public IEnumerable<IUsersModel> UsersModel
    {
        get { return usersModel; }
        set { usersModel = value; }
    }
    private IUsersModel selectedUser;
    public IUsersModel SelectedUser
    {
        get
        {
            return selectedUser;
        }
        set
        {
            selectedUser = value;
            OnPropertyChanged("SelectedUser");
        }
    }
    private async Task RefreshUsers()
    {
        UsersModel = await Task.Run(() => model.Service.TGetUsers());
    }
    public async Task TAddUser()
    {
        try
        {
            await Task.Run(() => model.Service.TAddUser(SelectedUser.UserId, SelectedUser.Name, SelectedUser.Surname));
            await Task.Run(() => RefreshUsers());
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
    public async Task TUpdateUser()
    {
        try
        {
            await Task.Run(() => model.Service.TUpdateUser(SelectedUser.UserId, SelectedUser.Name, SelectedUser.Surname));
            await Task.Run(() => RefreshUsers());
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
    public async Task TDeleteUser()
    {
        try
        {
            await Task.Run(() => model.Service.TDeleteUser(SelectedUser.UserId, SelectedUser.Name, SelectedUser.Surname));
            await Task.Run(() => RefreshUsers());
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
    //Rent
    //TO IMPLEMENT
    //Return
    //TO IMMPLEMENT
    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    
    
}