using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System37 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component248>().Inc<Component429>().Inc<Component97>().Inc<Component128>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component100>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component100>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component320>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component320>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component409>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component409>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component237>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component237>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
