﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestSharp;

namespace MFaaP.MFWSClient.Tests
{
	[TestClass]
	public class MFWSVaultValueListItemOperations
	{

		#region GetValueListItems

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItemsAsync"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public async Task GetValueListItemsAsync()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.GetValueListItemsAsync(1);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItems"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public void GetValueListItems()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items");

			// Execute.
			runner.MFWSClient.ValueListItemOperations.GetValueListItems(1);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItemsAsync"/>
		/// requests the correct resource using the correct method (when using a name filter).
		/// </summary>
		[TestMethod]
		public async Task GetValueListItemsAsync_WithNameFilter()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items?filter=hello");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.GetValueListItemsAsync(1, "hello");

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItems"/>
		/// requests the correct resource using the correct method (when using a name filter).
		/// </summary>
		[TestMethod]
		public void GetValueListItems_WithNameFilter()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items?filter=hello");

			// Execute.
			runner.MFWSClient.ValueListItemOperations.GetValueListItems(1, "hello");

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItemsAsync"/>
		/// requests the correct resource using the correct method (when using a limit).
		/// </summary>
		[TestMethod]
		public async Task GetValueListItemsAsync_WithLimit()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items?limit=501");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.GetValueListItemsAsync(1, limit: 501);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItems"/>
		/// requests the correct resource using the correct method (when using a limit).
		/// </summary>
		[TestMethod]
		public void GetValueListItems_WithLimit()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items?limit=501");

			// Execute.
			runner.MFWSClient.ValueListItemOperations.GetValueListItems(1, limit: 501);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItemsAsync"/>
		/// requests the correct resource using the correct method (when using a name filter and limit).
		/// </summary>
		[TestMethod]
		public async Task GetValueListItemsAsync_WithLimitAndNameFilter()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items?filter=hello&limit=501");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.GetValueListItemsAsync(1, "hello", limit: 501);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.GetValueListItems"/>
		/// requests the correct resource using the correct method (when using a name filter and limit).
		/// </summary>
		[TestMethod]
		public void GetValueListItems_WithLimitAndNameFilter()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<Results<ValueListItem>>(Method.GET, "/REST/valuelists/1/items?filter=hello&limit=501");

			// Execute.
			runner.MFWSClient.ValueListItemOperations.GetValueListItems(1, "hello", limit: 501);

			// Verify.
			runner.Verify();
		}

		#endregion

		#region AddValueListItem

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.CreateValueListItemAsync"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public async Task AddValueListItemByNameAsync()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Set the expected body.
			var newVLitem = new ValueListItem
			{
				ValueListID = 1,
				Name = "new valuelistItem name"
			};

			runner.SetExpectedRequestBody(newVLitem);

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.AddValueListItemAsync(1, "new valuelistItem name");

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.AddValueListItemAsync"/>
		/// excepts with a null name.
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public async Task AddValueListItemByNameAsyncThrowsWithNullName()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.AddValueListItemAsync(1, newItemName: null);
		}

		/// <summary>
		/// Ensures that <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.AddValueListItemAsync"/>
		/// excepts with a blank name.
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public async Task AddValueListItemByNameAsyncThrowsWithBlankName()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.AddValueListItemAsync(1, newItemName: "");
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.AddValueListItem"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public void AddValueListItemByName()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Set the expected body.
			var newVLitem = new ValueListItem
			{
				ValueListID = 1,
				Name = "new valuelistItem name"
			};

			runner.SetExpectedRequestBody(newVLitem);


			// Execute.
			runner.MFWSClient.ValueListItemOperations.AddValueListItem(1, "new valuelistItem name");

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.AddValueListItemAsync"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public async Task AddValueListItemAsync()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Set the expected body.
			var newVLitem = new ValueListItem
			{
				ValueListID = 1,
				Name = "new valuelistItem name"
			};

			runner.SetExpectedRequestBody(newVLitem);

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.AddValueListItemAsync
			(
				1,
				newVLitem
			);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.AddValueListItemAsync"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public async Task AddValueListItemValueListIDPopulatedAsync()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/23/items");

			// Set the expected body.
			var newVLitem = new ValueListItem
			{
				ValueListID = 23,
				Name = "new valuelistItem name"
			};

			runner.SetExpectedRequestBody(newVLitem);

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.AddValueListItemAsync
			(
				23,
				new ValueListItem
				{
					Name = "new valuelistItem name"
				}
			);

			// Verify.
			runner.Verify();
		}

		/// <summary>
		/// Ensures that <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.AddValueListItemAsync"/>
		/// excepts with a null value.
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public async Task AddValueListItemAsyncThrowsWithNull()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Execute.
			await runner.MFWSClient.ValueListItemOperations.AddValueListItemAsync(1, valueListItem: null);
		}

		/// <summary>
		/// Ensures that a call to <see cref="MFaaP.MFWSClient.MFWSVaultValueListItemOperations.CreateValueListItem"/>
		/// requests the correct resource using the correct method.
		/// </summary>
		[TestMethod]
		public void AddValueListItem()
		{
			// Create our test runner.
			var runner = new RestApiTestRunner<ValueListItem>(Method.POST, "/REST/valuelists/1/items");

			// Set the expected body.
			var newVLitem = new ValueListItem
			{
				ValueListID = 1,
				Name = "new valuelistItem name"
			};

			runner.SetExpectedRequestBody(newVLitem);


			// Execute.
			runner.MFWSClient.ValueListItemOperations.AddValueListItem
			(
				1,
				newVLitem
			);

			// Verify.
			runner.Verify();
		}

		#endregion

	}
}
