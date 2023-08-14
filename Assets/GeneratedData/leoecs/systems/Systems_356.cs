using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System356 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component335,Component281> _filter = null;
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
