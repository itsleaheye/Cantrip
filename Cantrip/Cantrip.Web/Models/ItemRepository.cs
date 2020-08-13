﻿using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Cantrip.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<string, Item> items =
            new ConcurrentDictionary<string, Item>();

        public ItemRepository()
        {
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 1", Description = "This is an item description." });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 2", Description = "This is an item description." });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 3", Description = "This is an item description." });
        }

        public IEnumerable<Item> GetAll()
        {
            return items.Values;
        }

        public void Add(Item item)
        {
            item.Id = Guid.NewGuid().ToString();
            items[item.Id] = item;
        }

        public Item Get(string id)
        {
            items.TryGetValue(id, out Item item);
            return item;
        }

        public Item Remove(string id)
        {
            items.TryRemove(id, out Item item);
            return item;
        }

        public void Update(Item item)
        {
            items[item.Id] = item;
        }
    }
}
