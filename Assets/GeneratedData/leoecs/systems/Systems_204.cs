using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System204 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component467,Component461,Component386> _filter = null;
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
