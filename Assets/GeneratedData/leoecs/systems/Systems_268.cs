using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System268 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component94,Component129> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component29>())
   {
    entity.Del<Component29>();
   }
   else
   {
    entity.Replace(new Component29());
   }
  }
 }
}

}
