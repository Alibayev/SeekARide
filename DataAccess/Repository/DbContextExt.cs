﻿using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace SeekARide.DataAccess.Repository {
	class DbContextExt {
		public static DbContext GetDbContextFromEntity(object entity) {
			var object_context = GetObjectContextFromEntity(entity);

			if (object_context == null)
				return null;

			return new DbContext(object_context, dbContextOwnsObjectContext: false);
		}
		private static ObjectContext GetObjectContextFromEntity(object entity) {
			var field = entity.GetType().GetField("_entityWrapper");

			if (field == null)
				return null;

			var wrapper = field.GetValue(entity);
			var property = wrapper.GetType().GetProperty("Context");
			var context = (ObjectContext)property.GetValue(wrapper, null);

			return context;
		}
	}
}
