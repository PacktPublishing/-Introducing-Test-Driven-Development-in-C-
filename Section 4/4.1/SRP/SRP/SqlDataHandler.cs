using System;
using System.Collections.Generic;

namespace SRP
{
    public class SqlDataHandler
    {
        private readonly ICommandFactory _commandFactory;
        private readonly ISqlConnectionWrapper _connectionWrapper;

        public SqlDataHandler(ICommandFactory commandFactory, ISqlConnectionWrapper connectionWrapper)
        {
            _commandFactory = commandFactory;
            _connectionWrapper = connectionWrapper;
        }

        public IEnumerable<Entity> ReadEntities()
        {
            var entities = new List<Entity>();

            using (var readCommand = _commandFactory.RetriveSelectEntityCommand(_connectionWrapper.SqlConnection))
            {
                var reader = readCommand.ExecuteReader();

                while (reader.Read())
                {
                    var entity = new Entity
                    {
                        Value = reader.GetInt32(0),
                        Type = (EntityType) reader.GetInt32(1)
                    };

                    entities.Add(entity);
                }
                reader.Close();
            }

            return entities;
        }

        public void UpdateDataFieldInEntity(Entity entity)
        {
            var newValue = entity.GetNewValueBasedOnType();

            using (var updateCommand = _commandFactory.RetriveUpdateEntityCommand(_connectionWrapper.SqlConnection, entity, newValue))
            {
                updateCommand.ExecuteNonQuery();
            }
        }
    }
}
