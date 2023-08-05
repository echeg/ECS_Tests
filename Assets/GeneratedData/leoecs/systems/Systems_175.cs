using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System175 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component436,Component150> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component374>())
   {
    entity.Del<Component374>();
   }
   else
   {
    entity.Replace(new Component374());
   }
  }
 }
}

}
