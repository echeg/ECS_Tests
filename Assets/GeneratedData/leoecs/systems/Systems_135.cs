using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System135 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component109,Component147> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component387>())
   {
    entity.Del<Component387>();
   }
   else
   {
    entity.Replace(new Component387());
   }
  }
 }
}

}
