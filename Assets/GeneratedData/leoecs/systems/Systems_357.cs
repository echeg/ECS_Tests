using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System357 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component330,Component143,Component419> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component26>())
   {
    entity.Del<Component26>();
   }
   else
   {
    entity.Replace(new Component26());
   }
  }
 }
}

}
