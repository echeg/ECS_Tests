using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System263 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component330,Component209,Component176> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component427>())
   {
    q+=1;
    var com = entity.Get<Component427>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component282>())
   {
    q+=1;
    var com = entity.Get<Component282>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component284>())
   {
    q+=1;
    var com = entity.Get<Component284>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component329>())
   {
    q+=1;
    var com = entity.Get<Component329>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
