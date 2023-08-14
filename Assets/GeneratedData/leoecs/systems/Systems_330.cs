using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System330 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component477> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component360>())
   {
    entity.Del<Component360>();
   }
   else
   {
    entity.Replace(new Component360());
   }
  }
 }
}

}
