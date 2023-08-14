using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System266 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component214,Component92,Component164> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component177>())
   {
    entity.Del<Component177>();
   }
   else
   {
    entity.Replace(new Component177());
   }
  }
 }
}

}
