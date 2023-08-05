using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System349 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component71,Component368,Component495> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component379>())
   {
    q+=1;
    var com = entity.Get<Component379>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component426>())
   {
    q+=1;
    var com = entity.Get<Component426>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component238>())
   {
    q+=1;
    var com = entity.Get<Component238>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component473>())
   {
    q+=1;
    var com = entity.Get<Component473>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
