using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System209 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component1,Component338,Component449> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component172>())
   {
    entity.Del<Component172>();
   }
   else
   {
    entity.Replace(new Component172());
   }
  }
 }
}

}
