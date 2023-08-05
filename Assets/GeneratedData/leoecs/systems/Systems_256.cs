using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System256 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component15,Component282,Component0,Component69> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component125>())
   {
    q+=1;
    var com = entity.Get<Component125>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component222>())
   {
    q+=1;
    var com = entity.Get<Component222>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component219>())
   {
    q+=1;
    var com = entity.Get<Component219>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component92>())
   {
    q+=1;
    var com = entity.Get<Component92>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
