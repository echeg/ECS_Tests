using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System341 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component405> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component372>())
   {
    entity.Del<Component372>();
   }
   else
   {
    entity.Replace(new Component372());
   }
  }
 }
}

}
