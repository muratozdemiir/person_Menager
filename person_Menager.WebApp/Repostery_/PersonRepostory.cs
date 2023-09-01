﻿using person_Menager.WebApp.Models;

namespace person_Menager.WebApp.Repostery_;


public class PersonRepository
{
    private readonly List<Person> _persons;
    public PersonRepository()
    {
        _persons = new List<Person>()
        {
            // Anonymous class
            new Person()
            {
                Id = 1,
                Name = "Gülsu",
                Surname= "Doğan",
                Email= "gulsu@gmail.com",
                Age= 22,
                Phone = "05324567894"
            },
                   new Person()
            {
                Id = 2,
                Name = "Muhammed",
                Surname= "Puşulu",
                Email= "muhammed@gmail.com",
                Age= 28,
                Phone = "05345678541"
            },
       new Person()
            {
                Id = 3,
                Name = "Mauro",
                Surname= "Icardi",
                Email= "mauro@gmail.com",
                Age= 29,
                Phone = "05412569874"
            }
        };
    }

    public List<Person> GetAll()
    {
        return _persons;
    }

    public void Add(Person person)
    {
        _persons.Add(person);
    }

    public Person GetById(int id)
    {
        // Düz yöntem 
        foreach (Person person in _persons)
        {
            if (person.Id == id) 
                return person;

        }

        return new Person()
        {
            Name = "Boş",
            Age = 0,
            Email = "Boş",
            Phone = "Boş",
            Id = id,
            Surname = "Boş"
        };
    }

    
    





}

  