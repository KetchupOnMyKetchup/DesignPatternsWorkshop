using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

public interface IAnimal
{
    void MakeNoise();
}

public interface IDog : IAnimal
{
    void ChaseMailman();
}

public interface ICat : IAnimal
{
    void PlayWithYarn();
}
public interface IAnimalManager
{
    IEnumerable<Lazy<IAnimal>> _animals { get; set; }
}

[Export(typeof(IAnimalManager))]
public class AnimalManager : IAnimalManager
{
    [ImportMany]
    public IEnumerable<Lazy<IAnimal>> _animals { get; set; }

    public T GetAnimal<T>() where T : IAnimal
    {
        Lazy<IAnimal> animal = _animals.SingleOrDefault(pet => pet.Value is T);
        if (animal == null) return default(T);
        return (T)animal.Value;
    }
}