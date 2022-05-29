using Service.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
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

    //Catalog
}