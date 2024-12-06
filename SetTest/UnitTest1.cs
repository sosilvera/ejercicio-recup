using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ConjuntoTests
{
    private Conjunto _conjunto;

    [SetUp]
    public void SetUp()
    {
        _conjunto = new Conjunto();
    }

    [Test]
    public void Add_ShouldReturnTrue_WhenElementIsAdded()
    {
        Assert.IsTrue(_conjunto.add("A"));
        Assert.IsTrue(_conjunto.exist("A"));
    }

    [Test]
    public void Add_ShouldReturnFalse_WhenElementAlreadyExists()
    {
        _conjunto.add("A");
        Assert.IsFalse(_conjunto.add("A"));
    }

    [Test]
    public void Remove_ShouldReturnTrue_WhenElementExists()
    {
        _conjunto.add("A");
        Assert.IsTrue(_conjunto.remove("A"));
        Assert.IsFalse(_conjunto.exist("A"));
    }

    [Test]
    public void Remove_ShouldReturnFalse_WhenElementDoesNotExist()
    {
        Assert.IsFalse(_conjunto.remove("A"));
    }

    [Test]
    public void Exist_ShouldReturnTrue_WhenElementExists()
    {
        _conjunto.add("A");
        Assert.IsTrue(_conjunto.exist("A"));
    }

    [Test]
    public void Exist_ShouldReturnFalse_WhenElementDoesNotExist()
    {
        Assert.IsFalse(_conjunto.exist("A"));
    }

    [Test]
    public void IsEmpty_ShouldReturnTrue_WhenConjuntoIsEmpty()
    {
        Assert.IsTrue(_conjunto.isEmpty());
    }

    [Test]
    public void IsEmpty_ShouldReturnFalse_WhenConjuntoIsNotEmpty()
    {
        _conjunto.add("A");
        Assert.IsFalse(_conjunto.isEmpty());
    }

    [Test]
    public void Get_ShouldReturnElement_WhenConjuntoIsNotEmpty()
    {
        _conjunto.add("A");
        Assert.AreEqual("A", _conjunto.get());
    }

    [Test]
    public void Get_ShouldReturnEmptyString_WhenConjuntoIsEmpty()
    {
        Assert.AreEqual("", _conjunto.get());
    }

    [Test]
    public void GetAll_ShouldReturnAllElements()
    {
        _conjunto.add("A");
        _conjunto.add("B");
        List<string> expected = new List<string> { "A", "B" };
        CollectionAssert.AreEquivalent(expected, _conjunto.getAll());
    }

    [Test]
    public void Union_ShouldReturnUnionOfTwoConjuntos()
    {
        _conjunto.add("A");
        _conjunto.add("B");

        Conjunto otroConjunto = new Conjunto();
        otroConjunto.add("B");
        otroConjunto.add("C");

        Conjunto union = _conjunto.union(otroConjunto);

        List<string> expected = new List<string> { "A", "B", "C" };
        CollectionAssert.AreEquivalent(expected, union.getAll());
    }

    [Test]
    public void Interseccion_ShouldReturnCommonElements()
    {
        _conjunto.add("A");
        _conjunto.add("B");

        Conjunto otroConjunto = new Conjunto();
        otroConjunto.add("B");
        otroConjunto.add("C");

        Conjunto interseccion = _conjunto.interseccion(otroConjunto);

        List<string> expected = new List<string> { "B" };
        CollectionAssert.AreEquivalent(expected, interseccion.getAll());
    }

    [Test]
    public void Interseccion_ShouldReturnEmptyConjunto_WhenNoCommonElements()
    {
        _conjunto.add("A");

        Conjunto otroConjunto = new Conjunto();
        otroConjunto.add("B");

        Conjunto interseccion = _conjunto.interseccion(otroConjunto);

        Assert.IsTrue(interseccion.isEmpty());
    }
}
