using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System129 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component137> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component429>())
   {
    entity.Del<Component429>();
   }
   else
   {
    entity.Replace(new Component429());
   }
  }
 }
}

}
