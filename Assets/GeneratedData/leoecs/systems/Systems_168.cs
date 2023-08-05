using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System168 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component119,Component101> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component126>())
   {
    entity.Del<Component126>();
   }
   else
   {
    entity.Replace(new Component126());
   }
  }
 }
}

}
