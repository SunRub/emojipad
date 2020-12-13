﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace emojipad.Shared
{
    public class EmojiContext : DbContext
    {
        public DbSet<Emoji> Emojis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=emoji-cache.db");
    }
}