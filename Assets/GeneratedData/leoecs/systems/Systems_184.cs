using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System184 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component492,Component197,Component436,Component394> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component153>())
   {
    entity.Del<Component153>();
   }
   else
   {
    entity.Replace(new Component153());
   }
  }
 }
}

}
