using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;

    private static List<Contact> _AllContacts = new List<Contact> {};

    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _AllContacts.Add(this);
      _id = _AllContacts.Count;
    }
    //
    // public void Save()
    // {
    //   _AllContacts.Add(this);
    // }

    public int GetId()
    {
      return _id;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public static List<Contact> GetAll()
    {
      return _AllContacts;
    }

    public static void ClearAll()
    {
      _AllContacts.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _AllContacts[searchId-1];
    }
  }
}
