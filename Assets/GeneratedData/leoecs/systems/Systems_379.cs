using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System379 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component204,Component74,Component128,Component22> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component277>())
   {
    entity.Del<Component277>();
   }
   else
   {
    entity.Replace(new Component277());
   }
  }
 }
}

}
