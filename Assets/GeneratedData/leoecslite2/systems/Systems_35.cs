using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System35 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component296>().Inc<Component271>().Inc<Component276>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component446>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component446>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component460>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component460>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component116>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component116>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component146>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component146>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
