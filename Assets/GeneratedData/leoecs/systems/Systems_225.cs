using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System225 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component238,Component304,Component184> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component193>())
   {
    entity.Del<Component193>();
   }
   else
   {
    entity.Replace(new Component193());
   }
  }
 }
}

}
