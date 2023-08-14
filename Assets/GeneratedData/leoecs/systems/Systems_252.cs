using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System252 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component152,Component209,Component101,Component457> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component69>())
   {
    entity.Del<Component69>();
   }
   else
   {
    entity.Replace(new Component69());
   }
  }
 }
}

}
