using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System233 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component352,Component432,Component276> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component411>())
   {
    entity.Del<Component411>();
   }
   else
   {
    entity.Replace(new Component411());
   }
  }
 }
}

}
