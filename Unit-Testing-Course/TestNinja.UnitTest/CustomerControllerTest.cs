using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
				[TestFixture]
				class CustomerControllerTest
				{
								private CustomerController _customer;
								[SetUp]
								public void SetUp()
								{
												_customer = new CustomerController();
								}

								[Test]
								public void GetCustomer_IdIsZero_ReturnNotFound()
								{

												var result = _customer.GetCustomer(0);

												// NotFound Object
												Assert.That(result, Is.TypeOf<NotFound>());

												// NotFound Object or its derivatives
												Assert.That(result, Is.InstanceOf<NotFound>());

								}

								[Test]
								public void GetCustomer_IdIsNotZero_ReturnOk()
								{
												var result = _customer.GetCustomer(1);

												Assert.That(result, Is.TypeOf<Ok>());
								}
				}

}
