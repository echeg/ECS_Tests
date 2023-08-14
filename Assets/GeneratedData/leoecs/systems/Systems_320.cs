using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System320 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component335,Component13> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component358>())
   {
    entity.Del<Component358>();
   }
   else
   {
    entity.Replace(new Component358());
   }
  }
 }
}

}
