using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System166 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component431,Component209,Component61,Component202> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component320>())
   {
    entity.Del<Component320>();
   }
   else
   {
    entity.Replace(new Component320());
   }
  }
 }
}

}
